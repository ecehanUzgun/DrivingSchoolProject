using BLL.Services.Abstracts;
using DAL.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;
using MODEL.Entities;

namespace BLL.Services.Concretes
{
    public class TeacherService : ServiceManager<Teacher>, ITeacherService
    {
        private readonly IRepository<Schedule> _scheduleRepository;
        private readonly IRepository<Student> _studentRepository;
        public TeacherService(IRepository<Teacher> repository, IRepository<Schedule> scheduleRepository, IRepository<Student> studentRepository) : base(repository)
        {
            _scheduleRepository = scheduleRepository;
            _studentRepository = studentRepository;
        }

        //Ders ekleme işlemi
        //public async Task<bool> AddLessonAsync(int teacherId, int studentId, DateTime date, TimeSpan startTime)
        //{
        //    //Çakışmayı kontrol et
        //    if (!await IsTimeAvailableAsync(teacherId, date, startTime)) return false;

        //    //Öğrencinin ders hakkını kontrol et
        //    var student = await _studentRepository.GetAll().FirstOrDefaultAsync(s => s.ID == studentId);
        //    if (student == null || student.CourseHours <= 0) return false;

        //    //Ders programı ekle
        //    var newSchedule = new Schedule
        //    {
        //        TeacherId = teacherId,
        //        StudentId = studentId,
        //        LessonDate = date,
        //        StartTime = startTime,
        //        Status = MODEL.Enums.DataStatus.Active
        //    };

        //    await _scheduleRepository.CreateAsync(newSchedule);

        //    //Öğrencinin ders hakkını azalt
        //    student.CourseHours -= 1;
        //    await _studentRepository.UpdateAsync(student);

        //    return true;
        //}

        // Öğretmenlerin listesini getirir
        public async Task<List<Teacher>> GetAllTeachersAsync()
        {
            return GetAll().ToList();
        }

        // Müsait günler
        public async Task<List<DateTime>> GetAvailableDatesAsync(int teacherId)
        {
            //Öğretmenin dolu günlerini getir
            var busyDates = await _scheduleRepository.GetAll()
                .Where(s => s.TeacherId == teacherId)
                .Select(s => s.LessonDate.Date)
                .Distinct()
                .ToListAsync();
            
            //Çalışma günlerinden dolu günleri çıkar
            var allDates = Enumerable.Range(0, 30)
                .Select(offset => DateTime.Now.Date.AddDays(offset)) //30 gün ileriye kadar günleri kontrol et
                .Except(busyDates)
                .ToList();

            return allDates;
        }

        //Müsait saatler
        public async Task<List<TimeSpan>> GetAvailableHoursAsync(int teacherId, DateTime date)
        {
            var workingHours = new List<TimeSpan>
            {
                new TimeSpan(8,0,0),
                new TimeSpan(10,0,0),
                new TimeSpan(13,0,0),
                new TimeSpan(15,0,0),
                new TimeSpan(17,0,0)
            };

            //Dolu saatleri getir
            var busyHours = await _scheduleRepository.GetAll()
                .Where(s => s.TeacherId == teacherId && s.LessonDate.Date == date.Date)
                .Select(s => s.StartTime)
                .ToListAsync();

            //Dolu saatleri çıkararak müsait saatleri döndür
            return workingHours.Except(busyHours).ToList();
        }

        //Ders çakışmasını kontrol et
        public async Task<bool> IsTimeAvailableAsync(int teacherId, DateTime date, TimeSpan startTime)
        {
            var isBusy = await _scheduleRepository.GetAll()
                .AnyAsync(s => s.TeacherId == teacherId && s.LessonDate.Date == date.Date && s.StartTime == startTime);

            return !isBusy;
        }
    }
}

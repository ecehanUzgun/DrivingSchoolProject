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

        // Öğretmenlerin listesini getirir
        public async Task<List<Teacher>> GetAllTeachersAsync()
        {
            return GetAll().ToList();
        }

        // Müsait günler
        public async Task<List<DateTime>> GetAvailableDatesAsync(int teacherId)
        {
            // Öğretmenin çalışma saatlerini tanımla
            var workingHours = new List<TimeSpan>
            {
                new TimeSpan(8, 0, 0),
                new TimeSpan(10, 0, 0),
                new TimeSpan(13, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(17, 0, 0)
            };

            //Öğretmenin tüm planlanmış derslerini al
            var schedules = await _scheduleRepository.GetAll()
                .Where(s => s.TeacherId == teacherId)
                .ToListAsync();
            //Tüm tarihleri kontrol et
            var busyDates = schedules
                .GroupBy(s => s.LessonDate.Date) //Tarihe göre grupla
                .Where(g => workingHours.All(hour => g.Any(s => s.StartTime == hour))) //Eğer tüm çalışma saatleri doluysa
                .Select(g => g.Key) //Tarihi seç
                .ToList();

            //Çalışma günlerinden dolu günleri çıkar
            var allDates = Enumerable.Range(0, 30)
                .Select(offset => DateTime.Now.Date.AddDays(offset)) //30 gün ileriye kadar günleri kontrol et
                .Except(busyDates) //Dolu günleri çıkar
                .ToList();

            return allDates;
        }

        //Müsait saatler
        public async Task<List<TimeSpan>> GetAvailableHoursAsync(int teacherId, DateTime date)
        {
            var workingHours = new List<TimeSpan>
            {
                new TimeSpan(8, 0, 0),
                new TimeSpan(10, 0, 0),
                new TimeSpan(13, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(17, 0, 0)
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
        public async Task<bool> IsTimeAvailableAsync(int teacherId, int studentId,DateTime date, TimeSpan startTime)
        {
            var isTeacherBusy = await _scheduleRepository.GetAll()
                .AnyAsync(s => s.TeacherId == teacherId && s.LessonDate.Date == date.Date && s.StartTime == startTime);

            var isStudentBusy = await _scheduleRepository.GetAll()
                .AnyAsync(s => s.StudentId == studentId && s.LessonDate == date.Date && s.StartTime == startTime);

            return !(isStudentBusy || isTeacherBusy);
        }
    }
}

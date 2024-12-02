using BLL.Services.Abstracts;
using DAL.Repository.Abstracts;
using DAL.Repository.Concretes;
using Microsoft.EntityFrameworkCore;
using MODEL.Entities;
using MODEL.Enums;

namespace BLL.Services.Concretes
{
    public class ScheduleService : ServiceManager<Schedule>, IScheduleService
    {
        private readonly IRepository<Student> _studentRepository;
        public ScheduleService(IRepository<Schedule> repository, IRepository<Student> studentRepository) : base(repository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<bool> AddLessonAsync(int teacherId, int studentId, DateTime date, TimeSpan startTime)
        {
            // Çakışmayı kontrol et
            var isTimeAvailable = !await _repository.GetAll()
                .AnyAsync(s => s.TeacherId == teacherId && s.LessonDate == date && s.StartTime == startTime);

            if (!isTimeAvailable)
                return false;

            // Öğrenci kontrolü
            var student = _studentRepository.GetById(studentId);
            if (student == null || student.CourseHours <= 0)
                return false;

            // Yeni ders oluştur
            var newSchedule = new Schedule
            {
                TeacherId = teacherId,
                StudentId = studentId,
                LessonDate = date,
                StartTime = startTime,
                Status = DataStatus.Active
            };

            await _repository.CreateAsync(newSchedule);

            // Öğrencinin ders hakkını azalt
            student.CourseHours--;
            await _studentRepository.UpdateAsync(student);

            return true;
        }


        public IEnumerable<Schedule> GetAllSchedules()
        {
            return GetAll();
        }

        public async Task<List<Schedule>> GetAllSchedulesWithDetailAsync()
        {
            return await _repository.GetAll()
                .Include(s => s.Teacher)
                .Include(s => s.Student)
                .ToListAsync();
        }

        public IEnumerable<Schedule> GetSchedulesByStudent(int studentId)
        {
            return GetAll().Where(s => s.StudentId == studentId);
        }

        public IEnumerable<Schedule> GetSchedulesByTeacher(int teacherId, DateTime date)
        {
            return GetAll().Where(s => s.TeacherId == teacherId && s.LessonDate.Date == date.Date);
        }

        public async Task UpdateLessonStatus(int scheduleId, DataStatus status)
        {
            var schedule = GetById(scheduleId);
            if (schedule != null)
            {
                schedule.Status = status;
                await UpdateAsync(schedule);
            }
        }
    }
}

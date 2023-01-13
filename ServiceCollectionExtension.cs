using LearnDigitally.Models;
using LearnDigitally.Repository.Base;
using LearnDigitally.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDigitally
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
           .AddScoped<ICandidate<Candidate>, CandidateService<Candidate>>()
           .AddScoped<IExam<Exam>, ExamService<Exam>>()
           .AddScoped<IQuestion<Question>, QuestionService<Question>>()
           .AddScoped<IResult<Result>, ResultService<Result>>();
        }
    }
}

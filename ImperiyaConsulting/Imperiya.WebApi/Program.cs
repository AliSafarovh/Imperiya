
using Imperiya.BusinessLayer.Abstract;
using Imperiya.BusinessLayer.Concrete;
using Imperiya.DataAccess.Abstract;
using Imperiya.DataAccess.Concrete;
using Imperiya.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imperiya.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<Context>();
            builder.Services.AddScoped<IAnimatedService,AnimatedManager>();
            builder.Services.AddScoped<ICommentService,CommentManager>();
            builder.Services.AddScoped<IHeaderService,HeaderManager>();
            builder.Services.AddScoped<IPartnerService,PartnerManager>();
            builder.Services.AddScoped<IPicsService,PicsManager>();
            builder.Services.AddScoped<IPublicityService,PublicityManager>();
            builder.Services.AddScoped<IServiceCardService,ServiceCardManager>();

            builder.Services.AddScoped<IAnimatedDal, EfAnimatedDal>();
            builder.Services.AddScoped<ICommentDal, EfCommentDal>();
            builder.Services.AddScoped<IHeaderDal, EfHeaderDal>();
            builder.Services.AddScoped<IPartnerDal, EfPartnerDal>();
            builder.Services.AddScoped<IPicsDal, EfPicsDal>();
            builder.Services.AddScoped<IPublicityDal, EfPublicityDal>();
            builder.Services.AddScoped<IServiceCardDal, EfServiceCardDal>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

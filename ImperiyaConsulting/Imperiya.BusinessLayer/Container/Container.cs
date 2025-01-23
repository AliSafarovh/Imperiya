using Imperiya.BusinessLayer.Abstract;
using Imperiya.BusinessLayer.Concrete;
using Imperiya.DataAccess.Abstract;
using Imperiya.DataAccess.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperiya.BusinessLayer.Container
{
    public static class Container
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAnimatedService, AnimatedManager>();
            services.AddScoped<IAnimatedDal, EfAnimatedDal>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IHeaderService, HeaderManager>();
            services.AddScoped<IHeaderDal, EfHeaderDal>();

            services.AddScoped<IPartnerService, PartnerManager>();
            services.AddScoped<IPartnerDal, EfPartnerDal>();

            services.AddScoped<IPicsService, PicsManager>();
            services.AddScoped<IPicsDal, EfPicsDal>();

            services.AddScoped<IPublicityService, PublicityManager>();
            services.AddScoped<IPublicityDal, EfPublicityDal>();

            services.AddScoped<IServiceCardService, ServiceCardManager>();
            services.AddScoped<IServiceCardDal, EfServiceCardDal>();

        }
    }
}
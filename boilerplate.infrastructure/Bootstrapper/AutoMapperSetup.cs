using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Boilerplate.Application.ViewModel.Mappers;

namespace Boilerplate.Infra.Bootstrapper
{
    public static class AutoMapperSetup
    {
        public static void AutoMapperActive(this IServiceCollection services)
        {
            services
                .AddSingleton(
                new MapperConfiguration(config =>
                {
                    config.AddProfile(new TransformationViewAnModel());
                    config.AddProfile(new TransformationModelAnView());
                })
                .CreateMapper());
        }
    }
}

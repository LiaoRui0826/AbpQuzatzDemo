﻿/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：继承IAsyncCrudAppService中定义了基础的 CRUD方法:
*              GetAsync, GetListAsync, CreateAsync, UpdateAsync 和 DeleteAsync                                                    
*│　作    者：yilezhu                                             
*│　版    本：1.0                                                 
*│　创建时间：2019/2/26 14:27:44                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Czar.AbpDemo.JobSchedule                                   
*│　接口名称： IJobInfoAppService                                      
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Czar.AbpDemo.JobSchedule
{
    public interface IJobInfoAppService :
        IAsyncCrudAppService< //定义了CRUD方法
            JobInfoDto, //用来展示任务
            int, //JobInfo实体的主键
            PagedAndSortedResultRequestDto, //获取任务的时候用于分页和排序
            CreateUpdateJobInfoDto, //用于创建任务
            CreateUpdateJobInfoDto> //用户更新任务
    {
        /// <summary>
        /// 应用程序停止时暂停所有任务
        /// </summary>
        /// <returns></returns>
        Task<bool> SystemStoppedAsync();
        /// <summary>
        /// 应用程序启动时启动所有任务
        /// </summary>
        /// <returns></returns>
        Task<bool> ResumeSystemStoppedAsync();
        /// <summary>
        /// 根据状态获取所有的任务列表
        /// </summary>
        /// <param name="jobStatu"></param>
        /// <returns></returns>
        Task<List<JobInfoDto>> GetListByJobStatuAsync(JobStatu jobStatu);


    }
}

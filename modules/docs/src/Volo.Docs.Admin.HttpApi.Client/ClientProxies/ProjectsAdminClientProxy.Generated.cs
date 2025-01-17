// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Docs.Admin.Projects;

// ReSharper disable once CheckNamespace
namespace Volo.Docs.Admin.ClientProxies
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(IProjectAdminAppService), typeof(ProjectsAdminClientProxy))]
    public partial class ProjectsAdminClientProxy : ClientProxyBase<IProjectAdminAppService>, IProjectAdminAppService
    {
        public virtual async Task<PagedResultDto<ProjectDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return await RequestAsync<PagedResultDto<ProjectDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
            {
                { typeof(PagedAndSortedResultRequestDto), input }
            });
        }

        public virtual async Task<ProjectDto> GetAsync(Guid id)
        {
            return await RequestAsync<ProjectDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
            {
                { typeof(Guid), id }
            });
        }

        public virtual async Task<ProjectDto> CreateAsync(CreateProjectDto input)
        {
            return await RequestAsync<ProjectDto>(nameof(CreateAsync), new ClientProxyRequestTypeValue
            {
                { typeof(CreateProjectDto), input }
            });
        }

        public virtual async Task<ProjectDto> UpdateAsync(Guid id, UpdateProjectDto input)
        {
            return await RequestAsync<ProjectDto>(nameof(UpdateAsync), new ClientProxyRequestTypeValue
            {
                { typeof(Guid), id },
                { typeof(UpdateProjectDto), input }
            });
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            await RequestAsync(nameof(DeleteAsync), new ClientProxyRequestTypeValue
            {
                { typeof(Guid), id }
            });
        }

        public virtual async Task ReindexAllAsync()
        {
            await RequestAsync(nameof(ReindexAllAsync));
        }

        public virtual async Task ReindexAsync(ReindexInput input)
        {
            await RequestAsync(nameof(ReindexAsync), new ClientProxyRequestTypeValue
            {
                { typeof(ReindexInput), input }
            });
        }
    }
}

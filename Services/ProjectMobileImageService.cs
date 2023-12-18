using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Services
{
    public class ProjectMobileImageService : BaseService<ProjectMobileImage>, IProjectMobileImageService
    {
        private ProjectContext _context;

        public ProjectMobileImageService(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public void SetFalse(List<ProjectMobileImage> projectMobileImages)
        {
            foreach (ProjectMobileImage projectMobileImage in projectMobileImages) 
            {
                projectMobileImage.IsActive = false;
                Update(projectMobileImage);
            }
            Save();
        }
    }
}

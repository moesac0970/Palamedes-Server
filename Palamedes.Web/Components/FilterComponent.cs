using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Palamedes.API.Models;
using Palamedes.Web.Helper;
using Palamedes.Web.ViewModels.Components;

namespace Palamedes.Web.Components
{
    [ViewComponent(Name = "Filter")]
    public class FilterComponent : ViewComponent
    {

        IConfiguration config;
        private IEnumerable<FilterVm> FilterCategories { get; set; }
        private List<Category> categories { get; set; }
        public FilterComponent(IConfiguration _configuration)
        {
            config = _configuration;
            string baseUri = config.GetSection("Data").GetSection("ApiBaseUri").Value;
            categories = WebApiHelper.GetApiResult<List<Category>>(baseUri + "categories");
        }
        

        public async Task<IViewComponentResult> InvokeAsync()
        {

            List<FilterVm> ApiCategories = new List<FilterVm>();
            foreach(var category in categories)
            {
                ApiCategories.Add(new FilterVm { CategoryName = category.Name.ToString().ToLower() });
            }
            FilterCategories = ApiCategories;

            return await Task.FromResult<IViewComponentResult>(View(FilterCategories));
        }

    }
}

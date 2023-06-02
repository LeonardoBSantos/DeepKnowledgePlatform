using Microsoft.AspNetCore.Mvc;

namespace DeepKnowledgePlatform.ViewComponents;

public class AdminFooterViewComponent: ViewComponent{
    public async Task<IViewComponentResult> InvokeAsync(){
        return await Task.Factory.StartNew(() => { return View();});
    } 
}

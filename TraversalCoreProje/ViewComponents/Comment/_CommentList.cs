using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            //ViewBag.commentCount = context.Comments.Where(x => x.DestinationID == id).Count();
            
            var values = commentManager.TGetListCommentWithDestinationAndUser(id);
            ViewBag.commentCount = values.Count();
            return View(values);
        }
    }
}

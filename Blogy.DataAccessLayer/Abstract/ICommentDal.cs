﻿using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.Abstract
{
    public interface ICommentDal:IGenericUowDal<Comment>
    {
        List<Comment> GetCommentListWithUser(int id);
        List<Comment> CommentListByUserId(int userId);
    }
}

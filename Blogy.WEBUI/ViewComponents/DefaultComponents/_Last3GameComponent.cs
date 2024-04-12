﻿using Blogy.BusinessLayer.Abstract;
using Blogy.DTOLayer.ArticleDtos;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WEBUI.ViewComponents.DefaultComponents
{
	public class _Last3GameComponent:ViewComponent
	{
		private readonly IArticleService _articleService;

		public _Last3GameComponent(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _articleService.TCategoryGameLast3Article();
			var result = values.Select(x => new GetArticleDto()
			{
				Content = x.Content,
				Date = x.CreatedDate,
				Id = x.ArticleID,
				ImageUrl = x.CoverImageUrl,
				Title = x.Title,
				NameSurname = x.AppUser.Name + " " + x.AppUser.Surname,
				UserImageUrl = x.AppUser.ImageUrl,
				CategoryID = x.CategoryID,
			}).ToList();
			return View(result);
		}

	}
}

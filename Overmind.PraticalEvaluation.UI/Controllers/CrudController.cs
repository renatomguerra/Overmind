using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Overmind.PraticalEvaluation.Application;
using Overmind.PraticalEvaluation.Application.Services;
using Overmind.PraticalEvaluation.Domain;
using Overmind.PraticalEvaluation.Infrastructure;
using System.ComponentModel;

namespace Overmind.PraticalEvaluation.UI.Controllers
{
    public abstract class CrudController<TDataKeyType, TEntity> : Controller
        where TEntity: BaseEntity<TDataKeyType>, new()
    {
        public IBaseService<TDataKeyType, TEntity> _service = null;
        public CrudController(IBaseService<TDataKeyType, TEntity> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_service.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new TEntity());
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Create(TEntity entity)
        {
            try
            {
                if (ModelState.IsValid == false)
                {
                    return View(entity);
                }

                _service.Add(entity);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Erro", e.Message);
                return View(entity);
            }
            return RedirectToAction("Index");
        }

        [HttpGet()]
        [Route("{id}")]
        public ActionResult Edit(TDataKeyType id)
        {
            TEntity entity = null;
            try
            {
                entity = _service.FindById(id).Result;

                if (entity == null)
                {
                    return HttpNotFound();
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
            }
            return View(entity);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public ActionResult Edit(TEntity entity)
        {
            try
            {
                _service.Update(entity);
            }
            catch(Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
                return View(entity);
            }

            return RedirectToAction("Index");
        }

        [HttpGet()]
        [Route("{id}")]
        public ActionResult Delete(TDataKeyType id)
        {
            TEntity entity = null;
            try
            {
                entity =  _service.FindById(id).Result;

                if (entity == null)
                {
                    return HttpNotFound();
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
            }
            return View(entity);
        }

        [HttpPost()]
        [Route("{id}")]
        public ActionResult Delete(TEntity entity)
        {
            try
            {
                _service.Delete(entity);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
                return View(entity);
            }
            return RedirectToAction("Index");
        }


    }
}
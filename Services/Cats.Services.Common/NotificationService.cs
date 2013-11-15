﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Cats.Data.UnitWork;
using Cats.Models;

namespace Cats.Services.Common
{
   public class NotificationService:INotificationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotificationService(UnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }


        #region Default Service Implementation
        public bool AddNotification(Notification notification)
        {
            _unitOfWork.NotificationRepository.Add(notification);
            _unitOfWork.Save();
            return true;

        }
        public bool EditNotification(Notification notification)
        {
            _unitOfWork.NotificationRepository.Edit(notification);
            _unitOfWork.Save();
            return true;

        }
        public bool DeleteNotification(Notification notification)
        {
            if (notification == null) return false;
            _unitOfWork.NotificationRepository.Delete(notification);
            _unitOfWork.Save();
            return true;
        }
        public bool DeleteById(int id)
        {
            var entity = _unitOfWork.NotificationRepository.FindById(id);
            if (entity == null) return false;
            _unitOfWork.NotificationRepository.Delete(entity);
            _unitOfWork.Save();
            return true;
        }
        public List<Notification> GetAllNotification()
        {
            return _unitOfWork.NotificationRepository.GetAll();
        }
        public Notification FindById(int id)
        {
            return _unitOfWork.NotificationRepository.FindById(id);
        }
        public List<Notification> FindBy(Expression<Func<Notification, bool>> predicate)
        {
            return _unitOfWork.NotificationRepository.FindBy(predicate);
        }

      
        #endregion


       

       
        public void Dispose()
        {
            _unitOfWork.Dispose();

        }

    
    }
}

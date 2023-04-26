using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiHub.View;

namespace TaxiHub.Services
{
    /// <summary>
    /// Реализация паттерна Singleton для форм.
    /// </summary>
    public static class SingletonFactoryForm
    {
        /// <summary>
        /// Форма с данными о машинах.
        /// </summary>
        private static CarsForm _carsForm;

        /// <summary>
        /// Форма с данными о водителях.
        /// </summary>
        private static DriversForm _driversForm;

        /// <summary>
        /// Форма с данными о клиентах.
        /// </summary>
        private static ClientsForm _clientsForm;

        /// <summary>
        /// Форма с данными о отзывах.
        /// </summary>
        private static FeedBackForm _feedBackForm;

        /// <summary>
        /// Форма с данными о заказах.
        /// </summary>
        private static OrdersForm _ordersForm;

        /// <summary>
        /// Форма с данными о клиентах и связанными с ними заказами.
        /// </summary>
        private static OrdersClientsForm _ordersClientsForm;

        /// <summary>
        /// Возвращает форму с данными о машинах.
        /// </summary>
        public static CarsForm CarsForm
        {
            get
            {
                return (_carsForm is null || _carsForm.IsDisposed)
                    ? _carsForm = new CarsForm()
                    : _carsForm;                 
            }
        }

        /// <summary>
        /// Возвращает форму с данными о водителях.
        /// </summary>
        public static DriversForm DriversForm
        {
            get
            {
                return (_driversForm is null || _driversForm.IsDisposed)
                    ? _driversForm = new DriversForm()
                    : _driversForm;
            }
        }

        /// <summary>
        /// Возвращает форму с данными о клиентах.
        /// </summary>
        public static ClientsForm ClientsForm
        {
            get
            {
                return (_clientsForm is null || _clientsForm.IsDisposed)
                    ? _clientsForm = new ClientsForm()
                    : _clientsForm;
            }
        }

        /// <summary>
        /// Возвращает форму с данными о отзывах.
        /// </summary>
        public static FeedBackForm FeedBackForm
        {
            get
            {
                return (_feedBackForm is null || _feedBackForm.IsDisposed)
                    ? _feedBackForm = new FeedBackForm()
                    : _feedBackForm;
            }
        }

        /// <summary>
        /// Возвращает форму с данными о заказах.
        /// </summary>
        public static OrdersForm OrdersForm
        {
            get
            {
                return (_ordersForm is null || _ordersForm.IsDisposed)
                    ? _ordersForm = new OrdersForm()
                    : _ordersForm;
            }
        }

        /// <summary>
        /// Возвращает форму с данными о клиентах и связанными с ними заказами.
        /// </summary>
        public static OrdersClientsForm OrdersClientsForm
        {
            get
            {
                return (_ordersClientsForm is null || _ordersClientsForm.IsDisposed)
                    ? _ordersClientsForm = new OrdersClientsForm()
                    : _ordersClientsForm;
            }
        }
    }
}

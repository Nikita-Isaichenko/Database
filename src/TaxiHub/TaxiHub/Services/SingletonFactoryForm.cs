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
    }
}

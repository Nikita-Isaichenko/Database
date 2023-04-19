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
        /// Возвращает форму с данными о машинах.
        /// </summary>
        public static CarsForm CarsForm
        {
            get
            {
                return (_carsForm is null || _carsForm.IsDisposed)
                    ? new CarsForm()
                    : _carsForm;                 
            }
        }
    }
}

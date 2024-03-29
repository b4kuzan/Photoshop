﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop
{
    public interface IFilter
    {
        /// <summary>
        /// Этот метод должен возвращать описание параметров, которые появляются в NumericUpDown-контроле
        /// снизу от контрола выбора фильтра
        /// </summary>
        /// <returns></returns>
  	    ParameterInfo[] GetParameters();
        /// <summary>
        /// Этот метод принимает фотографию, которую надо обрабатывать, и численные значения всех параметров
        /// Длина массива parameters в точности равна длине массива, возвращаемого методом GetParameters
        /// </summary>
        /// <param name="original"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
		Photo Process(Photo original, double[] parameters);
    }
}


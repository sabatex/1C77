﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C77.Models.Metadata
{
    public interface IAttributeSortedMetadata1C77
    {
        /// <summary>
        /// показывает, возможен ли отбор или поиск по данному реквизиту методами НайтиПоРеквизиту() или ВыбратьЭлементыПоРеквизиту()(Число [0 / 1])
        /// </summary>
        public bool Сортировка { get; set; }
    }
}

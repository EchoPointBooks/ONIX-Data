﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixData.Legacy
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OnixLegacyMeasure
    {
        #region CONSTANTS

        public const int CONST_MEASURE_TYPE_HEIGHT = 1;
        public const int CONST_MEASURE_TYPE_WIDTH  = 2;
        public const int CONST_MEASURE_TYPE_THICK  = 3;
        public const int CONST_MEASURE_TYPE_WEIGHT = 8;
        public const int CONST_MEASURE_TYPE_DIAMTR = 9;

        #endregion

        public OnixLegacyMeasure()
        {
            MeasureTypeCode = -1;
            Measurement     = 0;
            MeasureUnitCode = "";
        }

        private int     measureTypeCodeField;
        private decimal measurementField;
        private string  measureUnitCodeField;

        /// <remarks/>
        public int MeasureTypeCode
        {
            get
            {
                return this.measureTypeCodeField;
            }
            set
            {
                this.measureTypeCodeField = value;
            }
        }

        /// <remarks/>
        public decimal Measurement
        {
            get
            {
                return this.measurementField;
            }
            set
            {
                this.measurementField = value;
            }
        }

        /// <remarks/>
        public string MeasureUnitCode
        {
            get
            {
                return this.measureUnitCodeField;
            }
            set
            {
                this.measureUnitCodeField = value;
            }
        }
    }
}
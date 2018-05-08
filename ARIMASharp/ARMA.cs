using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.IntegralTransforms;

namespace ARIMASharp
{
    public class ARMA
    {

        protected double[] data;
        protected int ar_order = 0;
        protected int ma_order = 0;

        public ARMA(double[] data, int ar_order, int ma_order)
        {
            this.data = data;
            this.ar_order = ar_order;
            this.ma_order = ma_order;

        }

        /// <summary>
        /// The Fit function uses an ordinary Least Square Method to fit the model to the data. 
        /// </summary>
        public void Fit()
        {

        }

        /// <summary>
        /// Performs a prediction on the Time Series after the model was Fit.
        /// </summary>
        /// <param name="start_point"> starting point from which to start prediction</param>
        /// <param name="end_point"> ending point to which we stop the prediction</param>
        /// <returns>the predicted points.</returns>
        public double[] Predict(int start_point, int end_point)
        {
            List<double> pred = new List<double>();
            return pred.ToArray();
        }

    }
}

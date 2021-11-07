using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace encoderReader
{
    public class ChartSeriesExporter
    {

        public static void exportSeriesToCSV(System.Windows.Forms.DataVisualization.Charting.Series series, String cSVName) {
            String csvContent = "";


            string seriesName = series.Name;
            int pointCount = series.Points.Count;

            for (int p = 0; p < pointCount; p++)
            {
                DataPoint point = series.Points[p];
                string yValuesCSV = String.Empty;
                int count = point.YValues.Length;
                for (int i = 0; i < count; i++)
                {
                    yValuesCSV += point.YValues[i];

                    if (i != count - 1)
                        yValuesCSV += ",";
                }

                String csvLine = seriesName + "," + point.XValue + "," + yValuesCSV;
                csvContent += csvLine + "\r\n";
            }


            // Using stream writer class the chart points are exported. Create an instance of the stream writer class.
            StreamWriter file = new System.IO.StreamWriter(cSVName + ".csv");

            // Write the datapoints into the file.
            file.WriteLine(csvContent);

            file.Close();
        }
    }
}


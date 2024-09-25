using System.Reflection.PortableExecutable;
using Gpx;

namespace Rando
{
    public partial class Rando : Form
    {


        private const double LAT_OFFSET = 46.39;
        private const double LONG_OFFSET = 7.61;

        private List<GpxTrackPoint> trackPoints;



        public Rando()
        {
            InitializeComponent();
            using (GpxReader reader = new GpxReader(File.Open("gemmikandersteg.gpx", FileMode.Open)))
            {
                while (reader.Read())
                {
                    switch (reader.ObjectType)
                    {
                        case GpxObjectType.Metadata:
                            Console.WriteLine(reader.Metadata);
                            break;
                        case GpxObjectType.WayPoint:
                            Console.WriteLine(reader.WayPoint);
                            break;
                        case GpxObjectType.Route:
                            Console.WriteLine(reader.Route);
                            break;
                        case GpxObjectType.Track:
                            Console.WriteLine(reader.Track);
                            trackPoints = reader.Track.Segments[0].TrackPoints.ToList();
                            break;
                    }
                }
            }
        }

        private void Rando_Form_Paint(object sender, PaintEventArgs e)
        {
            Image background = Image.FromFile("C:\\Users\\pq17tmn\\Documents\\GitHub\\323-Programmation_fonctionnelle\\Personnel\\rando\\RandoBase\\Rando\\Rando\\Resources\\map.png");
            e.Graphics.DrawImage(background, new Rectangle(0, 0, this.Width, this.Height));

            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;

            Point[] points = new Point[4] { new Point(30, 50), new Point(50, 10), new Point(80, 50), new Point(111, 400) };
            this.CreateGraphics().DrawLines(myPen, points);


        }
        private async void Rando_Form_Paints(object sender, PaintEventArgs e)
        {
            await AnimateTrackAsync(e);
        }

        private void Rando_Load(object sender, EventArgs e)
        {

        }
        //a
        private void ReducePoints()
        {
            trackPoints = trackPoints.Where((p, index) => index % 5 == 0).ToList();
        }
        //b
        private double CalculateDistance(GpxTrackPoint p1, GpxTrackPoint p2)
        {
            double R = 6371e3; // Radio de la Tierra en metros
            double lat1 = p1.Latitude * Math.PI / 180;
            double lat2 = p2.Latitude * Math.PI / 180;
            double dLat = (p2.Latitude - p1.Latitude) * Math.PI / 180;
            double dLon = (p2.Longitude - p1.Longitude) * Math.PI / 180;

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return R * c; // Distancia en metros
        }

        private double CalculateTotalDistance()
        {
            double totalDistance = 0;
            for (int i = 1; i < trackPoints.Count; i++)
            {
                totalDistance += CalculateDistance(trackPoints[i - 1], trackPoints[i]);
            }
            return totalDistance;
        }
        //c
        private void CalculateElevation()
        {
            double positiveElevation = 0;
            double negativeElevation = 0;

            for (int i = 1; i < trackPoints.Count; i++)
            {
                // Asegúrate de que ambas elevaciones no sean nulas
                double? elevation1 = trackPoints[i - 1].Elevation;
                double? elevation2 = trackPoints[i].Elevation;

                if (elevation1.HasValue && elevation2.HasValue)
                {
                    double elevationDiff = elevation2.Value - elevation1.Value;
                    if (elevationDiff > 0)
                        positiveElevation += elevationDiff;
                    else
                        negativeElevation += Math.Abs(elevationDiff);
                }
            }

            Console.WriteLine($"Dénivelé positif: {positiveElevation} m");
            Console.WriteLine($"Dénivelé négatif: {negativeElevation} m");
        }


        //3.
        private async Task AnimateTrackAsync(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;

            for (int i = 1; i < trackPoints.Count; i++)
            {
                // Asegúrate de que las elevaciones no sean nulas
                double? elevation1 = trackPoints[i - 1].Elevation;
                double? elevation2 = trackPoints[i].Elevation;

                // Si ambas elevaciones tienen valor, calcula la diferencia
                double elevationDiff = 0;
                if (elevation1.HasValue && elevation2.HasValue)
                {
                    elevationDiff = Math.Abs(elevation2.Value - elevation1.Value);
                }

                // Calcula el retraso proporcional al desnivel
                int delay = (int)(elevationDiff * 10); // Retraso proporcional al desnivel
                await Task.Delay(delay); // Pausa antes de mostrar el siguiente punto

                // Asegúrate de que las coordenadas no sean nulas
                double? longitude1 = trackPoints[i - 1].Longitude;
                double? latitude1 = trackPoints[i - 1].Latitude;
                double? longitude2 = trackPoints[i].Longitude;
                double? latitude2 = trackPoints[i].Latitude;

                if (longitude1.HasValue && latitude1.HasValue && longitude2.HasValue && latitude2.HasValue)
                {
                    Point p1 = new Point((int)(longitude1.Value * 1000), (int)(latitude1.Value * 1000));
                    Point p2 = new Point((int)(longitude2.Value * 1000), (int)(latitude2.Value * 1000));

                    // Dibuja la línea entre los dos puntos
                    e.Graphics.DrawLine(myPen, p1, p2);
                }
            }
        }

        //5.
        private void MergeTracks(List<GpxTrackPoint> secondTrackPoints)
        {
            double distanceBetweenTracks = CalculateDistance(trackPoints.Last(), secondTrackPoints.First());
            if (distanceBetweenTracks < 100) // Menos de 100 metros de separación
            {
                trackPoints.AddRange(secondTrackPoints);
            }
            else
            {
                Console.WriteLine("Les points d’arrivée et de départ sont trop éloignés pour fusionner.");
            }
        }

    }
}

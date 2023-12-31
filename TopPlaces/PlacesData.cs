﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TopPlaces
{
    internal class PlacesData
    {
        private IList<Place> _placesList;

        public PlacesData()
        {
            _placesList = new List<Place>();
            string pathProject = Environment.CurrentDirectory;
            Place p1 = new Place(pathProject + "/photos/bruxelles.jpg", "Bruxelles");
            Place p2 = new Place(pathProject + "/photos/paris.jpg", "Paris");
            Place p3 = new Place(pathProject + "/photos/moscou.jpg", "Moscou");
            Place p4 = new Place(pathProject + "/photos/amsterdam.jpg", "Amsterdam");
            Place p5 = new Place(pathProject + "/photos/newyork.jpg", "New York");

            _placesList = new List<Place>();
            _placesList.Add(p1);
            _placesList.Add(p2);
            _placesList.Add(p3);
            _placesList.Add(p4);
            _placesList.Add(p5);

        }

        public IList<Place> GetPlaces()
        {
            return _placesList;
        }


    }

    internal class Place
    {
        private string _description;
        private string _pathImageFile;
        private int _nbVotes;
        private Uri _uri;
        private BitmapFrame _image;

        public Place(string path, string description)
        {
            _description = description;
            _pathImageFile = path;
            _nbVotes = 0;
            _uri = new Uri(_pathImageFile);
            _image = BitmapFrame.Create(_uri);
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string PathImageFile
        {
            get { return _pathImageFile; }
            set { _pathImageFile = value; }
        }

        public int NbVotes
        {
            get { return _nbVotes; }
            set { _nbVotes = value; }
        }

        public Uri Uri
        {
            get { return _uri; }
            set { _uri = value; }
        }

        public BitmapFrame Image
        {
            get { return _image; }
            set { _image = value; }
        }

    }
}

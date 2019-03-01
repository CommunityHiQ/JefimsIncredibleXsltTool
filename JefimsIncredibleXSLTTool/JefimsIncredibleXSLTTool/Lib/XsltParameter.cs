﻿namespace JefimsIncredibleXsltTool.Lib
{
    public class XsltParameter : Observable
    {
        private string _name;
        private string _value;

        public XsltParameter()
        {

        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }
    }
}

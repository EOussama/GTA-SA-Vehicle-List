using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_MP_Vehicle_List
{
    public class Class_Vehicle
    {
        private int _model_id;
        private string _model_name;
        private string _model_type;
        private string model_class;
        private string model_animation;
        private Image model_image;

        public int Model_id
        {
            get
            {
                return _model_id;
            }

            set
            {
                _model_id = value;
            }
        }

        public string Model_name
        {
            get
            {
                return _model_name;
            }

            set
            {
                _model_name = value;
            }
        }

        public string Model_type
        {
            get
            {
                return _model_type;
            }

            set
            {
                _model_type = value;
            }
        }

        public string Model_class
        {
            get
            {
                return model_class;
            }

            set
            {
                model_class = value;
            }
        }

        public string Model_animation
        {
            get
            {
                return model_animation;
            }

            set
            {
                model_animation = value;
            }
        }

        public Image Model_image
        {
            get
            {
                return model_image;
            }

            set
            {
                model_image = value;
            }
        }

        public Class_Vehicle(int Model_id, string Model_name, string Model_type, string Model_animation, string Model_class, Image Model_image)
        {
            this.Model_id = Model_id;
            this.Model_name = Model_name;
            this.Model_type = Model_type;
            this.Model_animation = Model_animation;
            this.Model_class = Model_class;
            this.Model_image = Model_image;
        }
    }
}

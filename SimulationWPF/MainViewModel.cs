﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationWPF
{
    using System.Windows.Media;
    using System.Windows.Media.Media3D;

    using HelixToolkit.Wpf;

    /// <summary>
    /// Provides a ViewModel for the Main window.
    /// </summary>
    public class MainViewModel
    {
        public Model3D AnimatedModel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
            //// Create a model group
            //var modelGroup = new Model3DGroup();

            //// Create a mesh builder and add a box to it
            //var meshBuilder = new MeshBuilder(false, false);
            //meshBuilder.AddBox(new Point3D(0, 0, 1), 1, 2, 0.5);
            //meshBuilder.AddBox(new Rect3D(0, 0, 1.2, 0.5, 1, 0.4));

            //// Create a mesh from the builder (and freeze it)
            //var mesh = meshBuilder.ToMesh(true);

            //// Create some materials
            //var greenMaterial = MaterialHelper.CreateMaterial(Colors.Green);
            //var redMaterial = MaterialHelper.CreateMaterial(Colors.Red);
            //var blueMaterial = MaterialHelper.CreateMaterial(Colors.Blue);
            //var insideMaterial = MaterialHelper.CreateMaterial(Colors.Yellow);

            //// Add 3 models to the group (using the same mesh, that's why we had to freeze it)
            //modelGroup.Children.Add(new GeometryModel3D { Geometry = mesh, Material = greenMaterial, BackMaterial = insideMaterial });
            //modelGroup.Children.Add(new GeometryModel3D { Geometry = mesh, Transform = new TranslateTransform3D(-2, 0, 0), Material = redMaterial, BackMaterial = insideMaterial });
            //modelGroup.Children.Add(new GeometryModel3D { Geometry = mesh, Transform = new TranslateTransform3D(2, 0, 0), Material = blueMaterial, BackMaterial = insideMaterial });

            //// Set the property, which will be bound to the Content property of the ModelVisual3D (see MainWindow.xaml)
            //this.Model = modelGroup;

            // Load the animated model
            //var modelImporter = new HelixToolkit.Wpf.AnimatedModelImporter();
            //Model3DGroup modelGroup = modelImporter.Load("3d/test_animated_cube.fbx"); // Replace "path_to_your_animated_model.fbx" with the actual path

            //// Set the property, which will be bound to the Content property of the ModelVisual3D (see MainWindow.xaml)
            //this.Model = modelGroup;

            //// Load your animated model here
            //var loader = new HelixToolkit.Wpf.ModelImporter();
            //AnimatedModel = loader.Load("C:\\Users\\joess\\source\\repos\\SimulationWPF\\SimulationWPF\\3d\\tolva_metal.obj");
            //HelixToolkit.Wpf.AnimationExtensions.AnimateOpacity(AnimatedModel, 30, 1000);
        }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        //public Model3D Model { get; set; }
    }
}

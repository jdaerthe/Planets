﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePlay : Page
    {
        Game game;
        public GamePlay()
        {
<<<<<<< HEAD
            this.InitializeComponent();
=======
           // this.InitializeComponent();
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
            game = new Game(this);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
<<<<<<< HEAD
            game.setup();
=======
            if (_contentLoaded == true) game.setup();
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
            
        }

        public Grid ContentPanel1
        {
            get { return ContentPanel; }
            set { ContentPanel = value; }
        }
    }
}

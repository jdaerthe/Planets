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
        ItemsPage p;
        public GamePlay()
        {
<<<<<<< HEAD
            this.InitializeComponent();
=======
           // this.InitializeComponent();
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
            game = new Game(this);
        }

        private void ClosePopupClicked(object sender, RoutedEventArgs e)
        {
            if (YouWin.IsOpen)
            {
                YouWin.IsOpen = false;
                return;
            }
            if (YouLose.IsOpen) { 
                YouLose.IsOpen = false;
                
            }
            this.Frame.Navigate(typeof(ItemsPage), "AllGroups");
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
<<<<<<< HEAD
           // p = (ItemsPage)e.Content;
=======
            
<<<<<<< HEAD
>>>>>>> 7395723aea8da5fff561b8e20616c6f37c826d7a
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
        public Popup YouLose1
        {
            get { return YouLose; }
            set { YouLose = value; }
        }
        public Popup HighScore1
        {
            get { return HighScore; }
            set { HighScore = value; }
        }
        public Popup YouWin1
        {
            get { return YouWin; }
            set { YouWin = value; }
        }
        public TextBlock Score1
        {
            get { return Score; }
            set { Score = value; }
        }
    }
}

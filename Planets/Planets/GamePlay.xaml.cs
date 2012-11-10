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
            this.InitializeComponent();
            game = new Game(this);
        }

        private void ClosePopupClicked(object sender, RoutedEventArgs e)
        {
            if (YouWin.IsOpen)
            {
                YouWin.IsOpen = false;
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
           // p = (ItemsPage)e.Content;
            game.setup();
            
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
        public Popup YouWin1
        {
            get { return YouWin; }
            set { YouWin = value; }
        }
    }
}

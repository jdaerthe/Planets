<<<<<<< HEAD
﻿using Planets.Common;

using System;
=======
﻿using System;
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

<<<<<<< HEAD
// The Split App template is documented at http://go.microsoft.com/fwlink/?LinkId=234228
=======
// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc

namespace Planets
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
<<<<<<< HEAD
        /// Initializes the singleton Application object.  This is the first line of authored code
=======
        /// Initializes the singleton application object.  This is the first line of authored code
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used when the application is launched to open a specific file, to display
        /// search results, and so forth.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
<<<<<<< HEAD
        protected override async void OnLaunched(LaunchActivatedEventArgs args)
=======
        protected override void OnLaunched(LaunchActivatedEventArgs args)
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
<<<<<<< HEAD
            
=======
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();
<<<<<<< HEAD
                //Associate the frame with a SuspensionManager key                                
                SuspensionManager.RegisterFrame(rootFrame, "AppFrame");

                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    // Restore the saved session state only when appropriate
                    try
                    {
                        await SuspensionManager.RestoreAsync();
                    }
                    catch (SuspensionManagerException)
                    {
                        //Something went wrong restoring state.
                        //Assume there is no state and continue
                    }
=======

                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }
<<<<<<< HEAD
=======

>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
            if (rootFrame.Content == null)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
<<<<<<< HEAD
                if (!rootFrame.Navigate(typeof(ItemsPage), "AllGroups"))
=======
                if (!rootFrame.Navigate(typeof(MainPage), args.Arguments))
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
                {
                    throw new Exception("Failed to create initial page");
                }
            }
            // Ensure the current window is active
            Window.Current.Activate();
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
<<<<<<< HEAD
        private async void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            await SuspensionManager.SaveAsync();
=======
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
            deferral.Complete();
        }
    }
}

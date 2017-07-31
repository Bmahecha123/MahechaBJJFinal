﻿using System;
using System.Linq;
using MahechaBJJ.Model;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class ProfilePage : ContentPage
    {
        //declare objects
        Grid grid;
        Image profileImage;
        Label nameLbl;
        Label nameTextLbl;
        Label emailLbl;
        Label emailTextLbl;
        Button cancelSubBtn;
        Button logOutBtn;

        public ProfilePage()
        {

            Title = "Profile";
            Padding = new Thickness(10, 30, 10, 10);
            //grid definiton
            grid = new Grid
            {
                RowDefinitions = new RowDefinitionCollection {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star)}
                },
                ColumnDefinitions = new ColumnDefinitionCollection {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)}
                }
            };

            //view Objects
            profileImage = new Image
            {
                //Source = user.Picture,
                Aspect = Aspect.AspectFit
            };
            nameLbl = new Label
            {
                Text = "Name:"
            };
            nameTextLbl = new Label
            {
                //Text = user.Name
            };
            emailLbl = new Label
            {
                Text = "Email:"
            };
            emailTextLbl = new Label
            {
                //Text = user.Email
            };
            cancelSubBtn = new Button
            {
                BackgroundColor = Color.Orange,
                Text = "Cancel Subscription"
            };
            logOutBtn = new Button
            {
                BackgroundColor = Color.Orange,
                Text = "Log Out"
            };
            //Events
            //TODO Enable account logout functionality with either Google and/or Facebook
            cancelSubBtn.Clicked += (sender, e) => {
                DisplayAlert("Subscription Cancellation", "Are you you want to cancel your subscription?!", "Yess D8<!", "Never >8D!");
            };
            //TODO FIGURE OUT HOW TO LOGOUT AND REMOVE THE PREVIOUS STACK SO THE USER CANT GO BACK
            logOutBtn.Clicked += async (sender, e) => {

                await DisplayAlert("test", "implement this shit later", "ok");
            };
            //Building Grid
            grid.Children.Add(profileImage, 0, 0);
            Grid.SetRowSpan(profileImage, 4);
            grid.Children.Add(nameLbl, 1, 0);
            grid.Children.Add(nameTextLbl, 1, 1);
            grid.Children.Add(emailLbl, 1, 2);
            grid.Children.Add(emailTextLbl, 1, 3);
            grid.Children.Add(cancelSubBtn, 0, 4);
            Grid.SetColumnSpan(cancelSubBtn, 2);
            grid.Children.Add(logOutBtn, 0, 5);
            Grid.SetColumnSpan(logOutBtn, 2);

            Content = grid;
        }
    }
}


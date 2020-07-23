﻿using NavegacaoExercicio1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavegacaoExercicio1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BemVindo : ContentPage
    {
        public BemVindo(Usuario usuario)
        {
            BindingContext = usuario;
            InitializeComponent();
        }
    }
}

using System.Diagnostics;

namespace MauiPageMemory;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    ~Page2()
    {
        Debug.WriteLine("~Page2() called");
    }
}
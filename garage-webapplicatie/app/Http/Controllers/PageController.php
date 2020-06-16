<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class PageController extends Controller
{

    public function home()
    {
        return view('pages.home');
    }

    public function dashboard()
    {
        return view('pages.dashboard');
    }

    public function appointment()
    {
        $appointmentOptions = \App\AppointmentOptions::all();

        // dd($appointmentOptions);

        return view('pages.appointment', compact('appointmentOptions'));
    }

}

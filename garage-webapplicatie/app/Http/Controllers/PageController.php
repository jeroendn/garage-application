<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class PageController extends Controller
{

    public function home()
    {
        return view('pages.home');
    }

    public function dashboard()
    {
        $appointments = \App\Appointment::where('user_id', Auth::user()->id)->get();

        return view('pages.dashboard', compact('appointments'));
    }

    public function appointment()
    {
        $appointments = \App\Appointment::all();
        $appointmentOptions = \App\AppointmentOptions::all();

        // dd($appointmentOptions);

        return view('pages.appointment', compact('appointments', 'appointmentOptions'));
    }

}

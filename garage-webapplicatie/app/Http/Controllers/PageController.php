<?php

namespace App\Http\Controllers;

use App\Appointment;
use Barryvdh\DomPDF\Facade as PDF;
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
        $appointments = \App\Appointment::orderBy('created_at', 'asc')->where('user_id', Auth::user()->id)->get();

        return view('pages.dashboard', compact('appointments'));
    }

    public function appointment()
    {
        $appointments = \App\Appointment::all();
        $appointmentOptions = \App\AppointmentOptions::all();

        return view('pages.appointment', compact('appointments', 'appointmentOptions'));
    }

    public function downloadInvoice($id)
    {
        $appointment = Appointment::find($id);
        $pdf = PDF::loadView('pages.invoice-download', compact('appointment'));

        return $pdf->download('Factuur_GarageOchten_' . $appointment->id . '.pdf');
    }

    public function payment($id)
    {
        $appointment = Appointment::find($id);

        return view('pages.payment', compact('appointment'));
    }

}

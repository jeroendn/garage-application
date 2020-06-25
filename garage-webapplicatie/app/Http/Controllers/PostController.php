<?php

namespace App\Http\Controllers;

use App\Appointment;
use Barryvdh\DomPDF\Facade as PDF;
use Egulias\EmailValidator\Exception\AtextAfterCFWS;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class PostController extends Controller
{

    public function makeAppointment(Request $request)
    {
        $request->validate([
            'licence' => 'required',
            'option' => 'required',
            'date' => 'required'
        ]);

        $appointment = new Appointment();

        $appointment->user_id = Auth::id();
        $appointment->option_id = request('option');
        if (!is_null(request('comment'))) { $appointment->comment = request('comment'); }
        $appointment->licence_plate = request('licence');
        $appointment->setCreatedAt(request('date'));
        $appointment->save();

        // dd($appointment);

        return redirect()->back()->with('message', 'Afspraak is succesvol geplanned.');
    }

    public function downloadInvoice($id) {
        $appointment = Appointment::find($id);
        $pdf = PDF::loadView('pages.invoice-download', compact('appointment'));

        return $pdf->download('invoice_' . $appointment->id . '.pdf');
    }

}

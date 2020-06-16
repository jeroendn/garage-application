<?php

namespace App\Http\Controllers;

use App\Appointment;
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
        $appointment->status_id = 1;
        $appointment->hours = 1;
        $appointment->total_price = 1;
        $appointment->licence_plate = request('licence');
        $appointment->setCreatedAt(request('date'));
        $appointment->save();

        // dd($appointment);

        return redirect()->back()->with('message', 'Afspraak is succesvol geplanned.');
    }

}

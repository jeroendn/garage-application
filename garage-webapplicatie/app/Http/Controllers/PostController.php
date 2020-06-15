<?php

namespace App\Http\Controllers;

use App\Appointment;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class PostController extends Controller
{

    public function makeAppointment(Request $request)
    {
        $request->validate([
            'licence' => 'required'
        ]);

        $appointment = new Appointment();

        $appointment->user_id = Auth::id();
        $appointment->option_id = 1;
        $appointment->comment = request('comment');
        $appointment->status_id = 1;
        $appointment->hours = 1;
        $appointment->total_price = 1;
        $appointment->licence_plate = request('licence');
        $appointment->save();

        dd($request->licence);

//        return redirect()->back();
    }

}

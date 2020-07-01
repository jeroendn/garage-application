<?php

namespace App\Http\Controllers;

use App\Appointment;
use App\Review;
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

        return redirect()->back()->with('message', 'Afspraak is succesvol geplanned!');
    }

    public function invoice()
    {
        $appointment = Appointment::where('id', request('appointment_id'))->first();

        return view('pages.invoice', compact('appointment'));
    }


    public function payment(Request $request)
    {
        $request->validate([
            'appointment_id' => 'required',
        ]);

        Appointment::find(1)->update(['status_id' => 5]);

        return redirect()->back()->with('message', 'Betaling is succesvol!');
    }

    public function postReview(Request $request)
    {
        $request->validate([
            'rating' => 'required',
            'review' => 'required'
        ]);

        $review = new Review();

        $review->user_id = Auth::id();
        $review->rating = request('rating');
        $review->review = request('review');
        $review->save();

        return redirect()->back()->with('message', 'Uw review is geplaatst!');
    }

}

@extends('app')

@section('title', 'Betalen - ' . env('APP_NAME'))

@section('content')

  @if(session()->has('message'))
    <div class="alert alert-success">
      {{ session()->get('message') }}
    </div>
  @endif

  <h2>Betaling factuur {{ $appointment->id }}</h2>
  <form method="POST" action="{{ action('PostController@invoice') }}">@csrf<input type="hidden" name="appointment_id" value="{{ $appointment->id }}"><button type="submit" class="btn btn-primary">Bekijk factuur</button></form>

  @if($appointment->status->id != 5)
    <div class="mt-5 mb-1">
      <p class="mb-3">Bedrag of te rekenen: <strong>&#8364;{{ $appointment->total_price }}</strong></p>
      <span><i>* Er zal een extern betaalvenster van uw bank openen.</i></span>
    </div>

    <form method="POST" action="{{ action('PostController@payment') }}">@csrf<input type="hidden" name="appointment_id" value="{{ $appointment->id }}"><button type="submit" class="btn btn-primary">Nu betalen</button></form>
  @endif

@endsection
@extends('app')

@section('title', 'Betalen - ' . env('APP_NAME'))

@section('content')

  <h2>Betaal factuur {{ $appointment->id }}</h2>
  <form method="POST" action="{{ action('PostController@invoice') }}">@csrf<input type="hidden" name="appointment_id" value="{{ $appointment->id }}"><button type="submit" class="btn btn-primary">Bekijk factuur</button></form>


@endsection
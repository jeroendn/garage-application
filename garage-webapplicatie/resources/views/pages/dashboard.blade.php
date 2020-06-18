@extends('app')

@section('title', 'Dashboard - ' . env('APP_NAME'))

@section('content')

@forelse($appointments as $appointment)
  <div>
    <p>{{ $appointment->status_id }}</p>
    <p>{{ $appointment->status->status }}</p>
  </div>
@empty
  <div><h2>U heeft nog geen afspraken gemaakt.</h2></div>
@endforelse

@endsection
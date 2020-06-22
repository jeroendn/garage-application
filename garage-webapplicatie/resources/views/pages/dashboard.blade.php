@extends('app')

@section('title', 'Dashboard - ' . env('APP_NAME'))

@section('content')

  <div class="appointment-row font-weight-bold">
    <p>Soort afspraak</p>
    <p>Toelichting</p>
    <p>Kenteken</p>
    <p>Gepland op</p>
    <p>Status</p>
    <p>Factuur</p>
    <p>Betaal</p>
  </div>

@forelse($appointments as $appointment)
  <div class="appointment-row">
    <p>{{ $appointment->option->option }}</p>
    <p>{{ $appointment->comment }}</p>
    <p>{{ $appointment->licence_plate }}</p>
    <p>{{ date('d M yy', strtotime($appointment->created_at)) }}</p>
    <p class="status" status="{{ $appointment->status->id }}">{{ $appointment->status->status }}</p>
    @if($appointment->status->id >= 4)
      <a href="#!">Factuur</a>
    @else
      <a href="#!"></a>
    @endif
    @if($appointment->status->id < 5)
      <a href="#!">Betaal</a>
    @else
      <a href="#!"></a>
    @endif
  </div>
@empty
  <div class="appointment-row">
    <h2>U heeft nog geen afspraken gemaakt.</h2>
  </div>
@endforelse

@endsection
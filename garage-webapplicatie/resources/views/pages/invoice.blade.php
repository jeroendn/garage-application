@extends('app')

@section('title', 'Invoice - ' . env('APP_NAME'))

@section('content')

  <div class="invoice">
    <h2>Invoice #{{ $appointment->id }}</h2>

    <div class="invoice-top">
      <table>
        <tbody>
        <tr>
          <td>Naam:</td>
          <td>{{ $appointment->user->firstname }} {{ $appointment->user->lastname }}</td>
        </tr>
        <tr>
          <td>E-mail:</td>
          <td>{{ $appointment->user->email }}</td>
        </tr>
        <tr>
          <td>Adres:</td>
          <td>{{ $appointment->user->zip }} {{ $appointment->user->street }} {{ $appointment->user->street_number }}</td>
        </tr>
        <tr>
          <td>Kenteken:</td>
          <td>{{ $appointment->licence_plate }}</td>
        </tr>
        <tr>
          <td>Datum:</td>
          <td>{{ date('d M yy', strtotime($appointment->created_at)) }}</td>
        </tr>
        </tbody>
      </table>

      <table>
        <tbody>
        <tr>
          <td>{{ env('APP_NAME') }}</td>
        </tr>
        <tr>
          <td>Ochtenseweg 9</td>
        </tr>
        <tr>
          <td>5678YT Ochten</td>
        </tr>
        <tr>
          <td>+06 12345678</td>
        </tr>
        <tr>
          <td>info@garageochten.nl</td>
        </tr>
        </tbody>
      </table>
    </div>

  </div>

@endsection
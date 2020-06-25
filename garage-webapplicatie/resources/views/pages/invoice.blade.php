@extends('app')

@section('title', 'Invoice - ' . env('APP_NAME'))

@section('content')

  <div class="invoice">
    <h2>Factuur #{{ $appointment->id }}</h2>

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

    <table class="table mt-4">
      <thead>
      <tr>
        <th>Product</th>
        <th>Prijs</th>
        <th>Qty</th>
        <th>Totaal</th>
      </tr>
      </thead>
      <tbody>
      <tr>
        <td>{{ $appointment->option->option }}</td>
        <td>&#8364;{{ $appointment->option->price_per_hour }} per uur</td>
        <td>{{ $appointment->hours }} uur</td>
        <td>&#8364;{{ number_format($appointment->option->price_per_hour * $appointment->hours, 2) }}</td>
      </tr>
      @forelse($appointment->parts as $part)
        <tr>
          <td>{{ $part->name }}</td>
          <td>&#8364;{{ $part->pivot->price_per_piece }} p.st.</td>
          <td>{{ $part->pivot->amount }}</td>
          <td>&#8364;{{ number_format($part->pivot->amount * $part->pivot->price_per_piece, 2) }}</td>
        </tr>
      @empty
        <tr>
          <td></td>
        </tr>
      @endforelse
      </tbody>
      <tfoot>
      <tr>
        <td>Subtotaal exc. BTW:</td>
        <td></td>
        <td></td>
        <td>&#8364;{{ number_format($appointment->total_price / 121 * 100, 2) }}</td>
      </tr>
      <tr>
        <td>BTW:</td>
        <td></td>
        <td>21%</td>
        <td>&#8364;{{ number_format($appointment->total_price / 121 * 21, 2) }}</td>
      </tr>
      <tr>
        <th>Totaalbedrag:</th>
        <th></th>
        <th></th>
        <th>&#8364;{{ number_format($appointment->total_price, 2) }}</th>
      </tr>
      </tfoot>
    </table>

    <a href="download-invoice/{{ $appointment->id }}" target="_blank" class="btn btn-primary">Download</a>

  </div>

@endsection
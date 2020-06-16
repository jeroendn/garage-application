@extends('app')

@section('title', 'Afspraak maken - ' . env('APP_NAME'))

@section('content')

  <div class="">
    <form method="POST" action="{{ action('PostController@makeAppointment') }}">
      @csrf

      {{--   options   --}}
      <div class="form-group row">
        <label for="option" class="col-md-4 col-form-label text-md-right">{{ __('Kies uw afspraak') }}</label>

        <div class="col-md-6">
          <select id="option" name="option" class="form-control">
            @forelse($appointmentOptions as $option)
              <option value="{{ $option->id }}">{{ $option->option }}</option>
            @empty
              <option value="" disabled>No options available</option>
            @endforelse
          </select>

          @error('option')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      {{--   comment   --}}
      <div class="form-group row">
        <label for="comment" class="col-md-4 col-form-label text-md-right">{{ __('Toelichting') }}</label>

        <div class="col-md-6">
          <textarea id="comment" class="form-control @error('comment') is-invalid @enderror" name="comment" maxlength="5592405" placeholder="(Optioneel) Voeg een toelichting toe"></textarea>

          @error('comment')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      {{--   licence plate   --}}
      <div class="form-group row">
        <label for="licence" class="col-md-4 col-form-label text-md-right">{{ __('Kenteken') }}</label>

        <div class="col-md-6">
          <input id="licence" type="text" class="form-control @error('licence') is-invalid @enderror" name="licence" value="{{ old('licence') }}"  placeholder="AA-00-AA" required>

          @error('licence')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      {{--   submit   --}}
      <div class="form-group row mb-0 d-flex justify-content-center">
        <button type="submit" class="btn btn-primary">
          {{ __('Maak afspraak') }}
        </button>
      </div>

    </form>
  </div>

@endsection
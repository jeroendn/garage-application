@extends('app')

@section('title', 'Home - ' . env('APP_NAME'))

@section('content')

  @if(!Auth::check())
  <div class="row box login-form">
    <form method="POST" action="{{ route('login') }}" class="col">
      @csrf

      <div class="form-group row">
        <label for="email" class="col-md-4 col-form-label text-md-right">{{ __('E-Mail Address') }}</label>

        <div class="col-md-6">
          <input id="email" type="email" class="form-control @error('email') is-invalid @enderror" name="email" value="{{ old('email') }}" required autocomplete="email" autofocus>

          @error('email')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      <div class="form-group row">
        <label for="password" class="col-md-4 col-form-label text-md-right">{{ __('Password') }}</label>

        <div class="col-md-6">
          <input id="password" type="password" class="form-control @error('password') is-invalid @enderror" name="password" required autocomplete="current-password">

          @error('password')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      <div class="form-group row">
        <div class="col-md-6 offset-md-4">
          <div class="form-check">
            <input class="form-check-input" type="checkbox" name="remember" id="remember" {{ old('remember') ? 'checked' : '' }}>

            <label class="form-check-label" for="remember">
              {{ __('Remember Me') }}
            </label>
          </div>
        </div>
      </div>

      <div class="form-group row mb-0">
        <div class="col-md-8 offset-md-4">
          <button type="submit" class="btn btn-primary">
            {{ __('Login') }}
          </button>

          @if (Route::has('password.request'))
            <a class="btn btn-link" href="{{ route('password.request') }}">
              {{ __('Forgot Your Password?') }}
            </a>
          @endif
        </div>
      </div>
    </form>

    <form method="POST" action="{{ route('register') }}" class="col">
      @csrf

      <div class="form-group row">
        <label for="firstname" class="col-md-4 col-form-label text-md-right">{{ __('Firstname') }}</label>

        <div class="col-md-6">
          <input id="firstname" type="text" class="form-control @error('firstname') is-invalid @enderror" name="firstname" value="{{ old('firstname') }}" required autocomplete="firstname" autofocus>

          @error('firstname')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      <div class="form-group row">
        <label for="lastname" class="col-md-4 col-form-label text-md-right">{{ __('Lastname') }}</label>

        <div class="col-md-6">
          <input id="lastname" type="text" class="form-control @error('lastname') is-invalid @enderror" name="lastname" value="{{ old('lastname') }}" required autocomplete="lastname" autofocus>

          @error('lastname')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      <div class="form-group row">
        <label for="street" class="col-md-4 col-form-label text-md-right">{{ __('Street') }}</label>

        <div class="col-md-6">
          <input id="street" type="text" class="form-control @error('street') is-invalid @enderror" name="street" value="{{ old('street') }}" required autocomplete="street" autofocus>

          @error('street')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      <div class="form-group row">
        <label for="street_number" class="col-md-4 col-form-label text-md-right">{{ __('Street_number') }}</label>

        <div class="col-md-6">
          <input id="street_number" type="text" class="form-control @error('street_number') is-invalid @enderror" name="street_number" value="{{ old('street_number') }}" required autocomplete="street_number" autofocus>

          @error('street_number')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      <div class="form-group row">
        <label for="zip" class="col-md-4 col-form-label text-md-right">{{ __('Zip') }}</label>

        <div class="col-md-6">
          <input id="zip" type="text" class="form-control @error('zip') is-invalid @enderror" name="zip" value="{{ old('zip') }}" required autocomplete="zip" autofocus>

          @error('zip')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      <div class="form-group row">
        <label for="email" class="col-md-4 col-form-label text-md-right">{{ __('E-Mail Address') }}</label>

        <div class="col-md-6">
          <input id="email" type="email" class="form-control @error('email') is-invalid @enderror" name="email" value="{{ old('email') }}" required autocomplete="email">

          @error('email')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      <div class="form-group row">
        <label for="password" class="col-md-4 col-form-label text-md-right">{{ __('Password') }}</label>

        <div class="col-md-6">
          <input id="password" type="password" class="form-control @error('password') is-invalid @enderror" name="password" required autocomplete="new-password">

          @error('password')
          <span class="invalid-feedback" role="alert">
            <strong>{{ $message }}</strong>
          </span>
          @enderror
        </div>
      </div>

      <div class="form-group row">
        <label for="password-confirm" class="col-md-4 col-form-label text-md-right">{{ __('Confirm Password') }}</label>

        <div class="col-md-6">
          <input id="password-confirm" type="password" class="form-control" name="password_confirmation" required autocomplete="new-password">
        </div>
      </div>

      <div class="form-group row mb-0">
        <div class="col-md-6 offset-md-4">
          <button type="submit" class="btn btn-primary">
            {{ __('Register') }}
          </button>
        </div>
      </div>
    </form>
  </div>
  @endif

  <div class="mt-5 mb-5">
    <p>Garage Ochten is gevestigd op de Ochtenseweg 9 in Ochten. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui.</p>
  </div>

  <div class="review-wrapper">
    <h2>Reviews over Garage Ochten</h2>
    @if(Auth::check())
    <from class="review-write mt-3 mb-5 d-block">
      @csrf
      <textarea class="form-control" style="min-height: 150px;" placeholder="Schrijf over uw ervaring..."></textarea>
      <button type="submit" class="btn btn-primary mt-2">Plaats</button>
    </from>
    @else
      <p>Log in om een beoordeling te kunnen plaatsen.</p>
    @endif

    <div class="reviews">
      @forelse($reviews as $review)
        <div class="review card card-body mb-3">
          <h5>{{ $review->user->firstname }} {{ $review->user->lastname }}</h5>
          <h4>{{ $review->rating }} / 5</h4>
          <p>{{ $review->review }}</p>
          <span>Geplaatst op: {{ date('d M yy', strtotime($review->created_at)) }}</span>
        </div>
      @empty
        {{ 'Geen reviews gevonden.' }}
      @endforelse
    </div>
  </div>

@endsection
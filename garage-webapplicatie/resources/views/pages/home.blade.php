@extends('app')

@section('title', 'Home - ' . env('APP_NAME'))

@section('content')

  @if(!Auth::check())
  <div class="row box login-form">
    <form method="POST" action="{{ route('login') }}" class="col">
      @csrf

      <div class="form-group row">
        <label for="email" class="col-md-4 col-form-label text-md-right">{{ __('auth.mail') }}</label>

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
        <label for="password" class="col-md-4 col-form-label text-md-right">{{ __('auth.password') }}</label>

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
              {{ __('auth.remember') }}
            </label>
          </div>
        </div>
      </div>

      <div class="form-group row mb-0">
        <div class="col-md-8 offset-md-4">
          <button type="submit" class="btn btn-primary">
            {{ __('auth.login') }}
          </button>

          @if (Route::has('password.request'))
            <a class="btn btn-link" href="{{ route('password.request') }}">
              {{ __('auth.forgotpassword') }}
            </a>
          @endif
        </div>
      </div>
    </form>

    <form method="POST" action="{{ route('register') }}" class="col">
      @csrf

      <div class="form-group row">
        <label for="firstname" class="col-md-4 col-form-label text-md-right">{{ __('auth.firstname') }}</label>

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
        <label for="lastname" class="col-md-4 col-form-label text-md-right">{{ __('auth.lastname') }}</label>

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
        <label for="street" class="col-md-4 col-form-label text-md-right">{{ __('auth.street') }}</label>

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
        <label for="street_number" class="col-md-4 col-form-label text-md-right">{{ __('auth.streetnumber') }}</label>

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
        <label for="zip" class="col-md-4 col-form-label text-md-right">{{ __('auth.zip') }}</label>

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
        <label for="email" class="col-md-4 col-form-label text-md-right">{{ __('auth.mail') }}</label>

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
        <label for="password" class="col-md-4 col-form-label text-md-right">{{ __('auth.password') }}</label>

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
        <label for="password-confirm" class="col-md-4 col-form-label text-md-right">{{ __('auth.confirmpassword') }}</label>

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
    <h2>Over ons</h2>
    <p>Garage Ochten is gevestigd op de Ochtenseweg 9 in Ochten. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui.</p>
  </div>

  <div class="mt-5 mb-5 banner container-full">
    <img src="https://www.autolenders.nl/wp-content/uploads/2015/04/Auto-Lenders-Werkplaats-2.jpg">
  </div>

  <div class="review-wrapper">
    @if(Auth::check())
    <h2>Geef een review</h2>
    <form method="POST" action="{{ action('PostController@postReview') }}" class="review-write mt-3 mb-5 d-block">

      @if(session()->has('message'))
        <div class="alert alert-success">
          {{ session()->get('message') }}
        </div>
      @endif

      @csrf
      <select id="rating" name="rating" class="form-control mb-3">
        <option value="5">5 Sterren</option>
        <option value="4">4 Sterren</option>
        <option value="3">3 Sterren</option>
        <option value="2">2 Sterren</option>
        <option value="1">1 Ster</option>
      </select>
      <textarea id="review" class="form-control mb-3" style="min-height: 150px;" placeholder="Schrijf over uw ervaring..." name="review"></textarea>
      <button type="submit" class="btn btn-primary">{{ __('Plaats review') }}</button>
    </form>
    @endif

    <h2>Reviews over Garage Ochten</h2>
    <h4><i>Onze klanten beoordelen ons gemiddeld met een </i><strong>{{ $averageRating }} / 5</strong></h4>
    @if(!Auth::check())
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
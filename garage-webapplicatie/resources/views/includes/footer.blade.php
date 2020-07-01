<footer>

  <div class="container pt-4 pb-4">
    <div class="row text-center text-xs-center text-sm-left text-md-left">
      <div class="col-xs-12 col-sm-4 col-md-4 cc_cursor">
        <h5>Pagina's</h5>
        <ul class="list-unstyled quick-links">
          <li><a href="{{ action('PageController@home') }}">Home</a></li>
          <li><a href="{{ action('PageController@dashboard') }}">Dashboard</a></li>
          <li><a href="{{ action('PageController@appointment') }}">Afspraak maken</a></li>
          <li><a href="{{ action('PageController@home') }}">Reviews</a></li>
          <li><a href="https://jeroendn.nl">Lorem ipsum</a></li>
        </ul>
      </div>
      <div class="col-xs-12 col-sm-4 col-md-4">
        <h5>Support</h5>
        <ul class="list-unstyled quick-links">
          <li><a href="{{ route('password.request') }}">Wachtwoord vergeten?</a></li>
          <li><a href="https://jeroendn.nl">Lorem ipsum</a></li>
          <li><a href="https://jeroendn.nl">Lorem ipsum</a></li>
          <li><a href="https://jeroendn.nl">Lorem ipsum</a></li>
          <li><a href="https://jeroendn.nl">Lorem ipsum</a></li>
        </ul>
      </div>
      <div class="col-xs-12 col-sm-4 col-md-4">
        <h5>Over {{ env('APP_NAME') }}</h5>
        <ul class="list-unstyled quick-links">
          <li><a href="{{ action('PageController@home') }}">Home</a></li>
          <li><a href="{{ action('PageController@dashboard') }}">Dashboard</a></li>
          <li><a href="{{ action('PageController@appointment') }}">Afspraak maken</a></li>
          <li><a href="/garageochten.exe" download>Download desktop applicatie</a></li>
          <li><a href="https://jeroendn.nl" target="_blank">jeroendn.nl</a></li>
        </ul>
      </div>
    </div>
  </div>

  <div class="container text-center">
    Copyright &copy; 2020 - {{ date('Y', $_SERVER['REQUEST_TIME']) }} <a href="https://jeroendn.nl" target="_blank">jeroendn.nl</a>
  </div>

</footer>
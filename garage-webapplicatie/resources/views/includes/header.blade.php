<header>
  <nav class="container navbar">

    <ul>
      <li><a href="/home">Home</a></li>
      <li><a href="/dashboard">Dashboard</a></li>
    </ul>

    <ul>
      @if(Auth::check())
        <div>
          <span>Welkom: {{ Auth::user()->firstname }} {{ Auth::user()->lastname }}</span>
          <span>{{ Auth::user()->email }}</span>
        </div>
        <li><a href="{{ route('logout') }}" onclick="event.preventDefault(); document.getElementById('logout-form').submit();">Uitloggen</a></li>
        <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
          @csrf
        </form>
      @endif

    </ul>

  </nav>
</header>
defmodule DotPhoenixWeb.PageController do
  use DotPhoenixWeb, :controller

  def index(conn, _params) do
    render conn, "index.html"
  end
end

class PagesController < ApplicationController
  def home
  end

  def about
  end

  def danhsachttb
    render json: Dmttb.all
  end
end

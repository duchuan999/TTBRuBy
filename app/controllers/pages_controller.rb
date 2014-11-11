class PagesController < ApplicationController
  def home
  end

  def about
  end

  def danhsachttb
    render :json=> Dmttb.loadall
  end
  def find_ttb
   # render json: Dmttb.find_by_sql("select * from medibv.dmttbs where id="+params[:id]+" ")
    render :json=> Dmttb.find(params[:id])
  end
end

class DmnhomnhaccsController < ApplicationController
  respond_to :html, :js

  def index
    @dmnhomnhaccs = Dmnhomnhacc.all
  end

  def show
    @dmnhomnhacc = Dmnhomnhacc.find(params[:id])
  end

  def edit
    @dmnhomnhacc = Dmnhomnhacc.find(params[:id])
  end

  def update
    @dmnhomnhaccs = Dmnhomnhacc.all
    @dmnhomnhacc = Dmnhomnhacc.find(params[:id])

    @dmnhomnhacc.update_attributes(dmnhomnhacc_params)
  end

  def new
    @dmnhomnhacc = Dmnhomnhacc.new
  end

  def create
    @dmnhomnhaccs = Dmnhomnhacc.all
    @dmnhomnhacc = Dmnhomnhacc.create(dmnhomnhacc_params)
  end

  def delete
    @dmnhomnhacc = Dmnhomnhacc.find(params[:dmnhomnhacc_id])
  end

  def destroy
    @dmnhomnhaccs = Dmnhomnhacc.all
    @dmnhomnhacc = Dmnhomnhacc.find(params[:id])
    @dmnhomnhacc.destroy
  end

  private
  def dmnhomnhacc_params
    params.require(:dmnhomnhacc).permit(:stt,:ten)
  end
end

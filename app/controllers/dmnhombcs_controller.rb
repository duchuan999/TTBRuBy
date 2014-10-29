class DmnhombcsController < ApplicationController
  respond_to :html, :js

  def index
    @dmnhombcs = Dmnhombc.all
  end

  def show
    @dmnhombc = Dmnhombc.find(params[:id])
  end

  def edit
    @dmnhombc = Dmnhombc.find(params[:id])
  end

  def update
    @dmnhombcs = Dmnhombc.all
    @dmnhombc = Dmnhombc.find(params[:id])

    @dmnhombc.update_attributes(dmnhombc_params)
  end

  def new
    @dmnhombc = Dmnhombc.new
  end

  def create
    @dmnhombcs = Dmnhombc.all
    @dmnhombc = Dmnhombc.create(dmnhombc_params)
  end

  def delete
    @dmnhombc = Dmnhombc.find(params[:dmnhombc_id])
  end

  def destroy
    @dmnhombcs = Dmnhombc.all
    @dmnhombc = Dmnhombc.find(params[:id])
    @dmnhombc.destroy
  end

  private
  def dmnhombc_params
    params.require(:dmnhombc).permit(:stt,:ten)
  end
end

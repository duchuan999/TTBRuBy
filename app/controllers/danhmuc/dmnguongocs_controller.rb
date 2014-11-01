module Danhmuc
  class DmnguongocsController < PageController
    respond_to :html, :js

    def index
      @dmnguongocs = Dmnguongoc.all
    end

    def show
      @dmnguongoc = Dmnguongoc.find(params[:id])
    end

    def edit
      @dmnguongoc = Dmnguongoc.find(params[:id])
    end

    def update
      @dmnguongocs = Dmnguongoc.all
      @dmnguongoc = Dmnguongoc.find(params[:id])

      @dmnguongoc.update_attributes(dmnguongoc_params)
    end

    def new
      @dmnguongoc = Dmnguongoc.new
    end

    def create
      @dmnguongocs = Dmnguongoc.all
      @dmnguongoc = Dmnguongoc.create(dmnguongoc_params)
    end

    def delete
      @dmnguongoc = Dmnguongoc.find(params[:dmnguongoc_id])
    end

    def destroy
      @dmnguongocs = Dmnguongoc.all
      @dmnguongoc = Dmnguongoc.find(params[:id])
      @dmnguongoc.destroy
    end

    private
    def dmnguongoc_params
      params.require(:dmnguongoc).permit(:stt, :ten)
    end
  end
end
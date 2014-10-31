module Danhmuc
  class DmdvtsController < PageController

    respond_to :html, :js

    def index
      @dmdvts = Dmdvt.all
    end

    def show
      @dmdvt = Dmdvt.find(params[:id])
    end

    def edit
      @dmdvt = Dmdvt.find(params[:id])
    end

    def update
      @dmdvts = Dmdvt.all
      @dmdvt = Dmdvt.find(params[:id])

      @dmdvt.update_attributes(dmdvt_params)
    end

    def new
      @dmdvt = Dmdvt.new
    end

    def create
      @dmdvts = Dmdvt.all
      @dmdvt = Dmdvt.create(dmdvt_params)
    end

    def delete
      @dmdvt = Dmdvt.find(params[:dmdvt_id])
    end

    def destroy
      @dmdvts = Dmdvt.all
      @dmdvt = Dmdvt.find(params[:id])
      @dmdvt.destroy
    end

    private
    def dmdvt_params
      params.require(:dmdvt).permit(:stt, :ten)
    end
  end
end
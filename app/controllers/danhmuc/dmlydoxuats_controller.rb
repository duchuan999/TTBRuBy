module Danhmuc
  class DmlydoxuatsController < PageController
    respond_to :html, :js

    def index
      @dmlydoxuats = Dmlydoxuat.all
    end

    def show
      @dmlydoxuat = Dmlydoxuat.find(params[:id])
    end

    def edit
      @dmlydoxuat = Dmlydoxuat.find(params[:id])
    end

    def update
      @dmlydoxuats = Dmlydoxuat.all
      @dmlydoxuat = Dmlydoxuat.find(params[:id])

      @dmlydoxuat.update_attributes(dmlydoxuat_params)
    end

    def new
      @dmlydoxuat = Dmlydoxuat.new
    end

    def create
      @dmlydoxuats = Dmlydoxuat.all
      @dmlydoxuat = Dmlydoxuat.create(dmlydoxuat_params)
    end

    def delete
      @dmlydoxuat = Dmlydoxuat.find(params[:dmlydoxuat_id])
    end

    def destroy
      @dmlydoxuats = Dmlydoxuat.all
      @dmlydoxuat = Dmlydoxuat.find(params[:id])
      @dmlydoxuat.destroy
    end

    private
    def dmlydoxuat_params
      params.require(:dmlydoxuat).permit(:stt, :ten)
    end
  end
end
